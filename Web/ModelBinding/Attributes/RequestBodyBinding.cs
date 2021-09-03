using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace Web.ModelBinding.Attributes
{
    public class RequestBodyBinding : IModelBinder
    {
        public RequestBodyBinding()
        {

        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var result = new object();
            var paramName = bindingContext.FieldName;
            var paramType = bindingContext.ModelType;
            var httpContext = bindingContext.HttpContext;
            if (paramType.IsClass && paramType.Name != typeof(String).Name)
            {
                result = this.BindClassType(paramType, httpContext);
            }
            else
            {
                result = this.BindNativeType(paramType, httpContext, paramName);
            }
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }

        //public virtual object BindNativeType(Type paramType, HttpContext httpContext, string paramName)
        //{
        //    var rawValue = string.Empty;
        //    try
        //    {
        //        rawValue = httpContext.Request.Form[paramName];
        //        var converter = TypeDescriptor.GetConverter(paramType);
        //        var result = converter.ConvertFromString(rawValue);
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"{paramName} binding fails,native value :{rawValue} to {paramType.Name}", ex);
        //    }
        //}

        //public virtual object BindClassType(Type type, HttpContext httpContext)
        //{
        //    var value = Activator.CreateInstance(type);
        //    foreach (var prop in type.GetProperties())
        //    {
        //        var propName = prop.Name;
        //        var propType = prop.PropertyType;
        //        var propNativeValue = string.Empty;
        //        try
        //        {
        //            propNativeValue = httpContext.Request.Form[propName];
        //            var converter = TypeDescriptor.GetConverter(propType);
        //            var propVal = converter.ConvertFromString(propNativeValue);
        //            prop.SetValue(value, propVal);
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception($"{propName} binding fails,class value :{propNativeValue} to {propType.Name}", ex);
        //        }
        //    }
        //    return value;
        //}

        public virtual object BindClassType(Type type, HttpContext httpContext)
        {
            var value = Activator.CreateInstance(type);
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                var propName = prop.Name;
                var propNativeValue = httpContext.Request.Form[propName];
                var propType = prop.PropertyType;
                if (propType.IsClass && propType.Name != typeof(String).Name)
                {
                    object propVal = this.BindClassType(propType, httpContext);
                    prop.SetValue(value, propVal, null);
                }
                else
                {
                    try
                    {
                        var propVal = Convert.ChangeType(propNativeValue, propType);
                        prop.SetValue(value, propVal);
                    }
                    //Nullable型別會進入這裡
                    catch (InvalidCastException)
                    {
                        try
                        {
                            Type nullableType = Nullable.GetUnderlyingType(propType) ?? propType;
                            var converter = TypeDescriptor.GetConverter(propType);
                            object propVal = string.IsNullOrEmpty(propNativeValue) ? null : converter.ConvertFromString(propNativeValue);
                            prop.SetValue(value, propVal, null);
                        }
#warning 加上exception類別
                        catch (Exception ex)
                        {
                            //throw new Exception($"InvalidCastException {propName} binding fails,native value :{ propNativeValue} to {propType.Name}", ex);
                            value = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"{propName} binding fails,native value :{ propNativeValue} to {propType.Name}", ex);
                    }
                }
            }
            return value;
        }

        public virtual object BindNativeType(Type type, HttpContext httpContext, string name)
        {
            try
            {

                var rawValue = string.Empty;

#warning 此功能無法讀JSON
                if (httpContext.Request.ContentType.Contains("application/json"))
                {
                    httpContext.Request.Body.Position = 0;
                    rawValue = JObject.Parse(new StreamReader(httpContext.Request.Body).ReadToEnd())[name].ToString();
                }
                else
                {
                    rawValue = httpContext.Request.Form[name];
                }

                var converter = TypeDescriptor.GetConverter(type);
                var propVal = converter.ConvertFromString(rawValue);
                return propVal;
            }
            catch (NullReferenceException)
            {
                return null;
            }
            catch (FormatException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
