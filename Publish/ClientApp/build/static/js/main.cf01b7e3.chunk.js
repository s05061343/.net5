(this.webpackJsonpwebui=this.webpackJsonpwebui||[]).push([[0],{38:function(e,t,n){e.exports=n(58)},49:function(e,t,n){},57:function(e,t,n){},58:function(e,t,n){"use strict";n.r(t);n(39);var a=n(0),r=n.n(a),l=n(15),o=n(9),s=n(19),c=n(8),i=n(25),m=n(14),u=n(34),d=n(28);const p={post:()=>(e,t)=>{const n=t();let a=new FormData;a.append("userId",n.loginUser.user.userId),fetch("auth/default/Login",{method:"POST",body:a}).then(e=>e.json()).then(t=>{sessionStorage.setItem("authToken",JSON.stringify(t.authToken)),e({type:"POST_LOGIN",user:{authToken:t.authToken,userId:t.userId,password:"",isAuth:!!t.authToken}})}).catch(e=>{})},setUserId:e=>(t,n)=>{const a=n();t({type:"SET_USERID",user:{authToken:"",userId:e,password:a.loginUser.user.password,isAuth:!1}})},setPassword:e=>(t,n)=>{t({type:"SET_PASSWORD",user:{authToken:"",userId:n().loginUser.user.userId,password:e,isAuth:!1}})}},E={loginUser:(e,t)=>{if(void 0===e)return{user:{authToken:"",userId:"",password:"",isAuth:!1}};const n=t;switch(console.log(n),n.type){case"POST_LOGIN":case"SET_USERID":return{user:n.user};default:return e}}};var h=n(13),g=n(11),b=n(36);class f extends r.a.Component{render(){console.log(this.props);const e=this.props,t=e.component,n=(e.pending,e.user,Object(b.a)(e,["component","pending","user"]));console.log(this.props.location.pathname);const a=sessionStorage.getItem("authToken");return console.log(a),a&&console.log("pass"),r.a.createElement(g.b,Object.assign({},n,{render:e=>a?r.a.createElement(t,e):r.a.createElement(g.a,{to:"/login"})}))}}var v=Object(o.c)(e=>e.loginUser)(f),w=n(60),y=n(59),N=n(61),O=n(62),k=n(65),x=n(63),I=n(64);n(49);class T extends a.PureComponent{constructor(...e){super(...e),this.state={isOpen:!1},this.toggle=()=>{this.setState({isOpen:!this.state.isOpen})}}render(){return a.createElement("header",null,a.createElement(y.a,{className:"navbar-expand-sm navbar-toggleable-sm border-bottom box-shadow mb-3",light:!0},a.createElement(w.a,null,a.createElement(N.a,{tag:h.b,to:"/"},"WebUI"),a.createElement(O.a,{onClick:this.toggle,className:"mr-2"}),a.createElement(k.a,{className:"d-sm-inline-flex flex-sm-row-reverse",isOpen:this.state.isOpen,navbar:!0},a.createElement("ul",{className:"navbar-nav flex-grow"},a.createElement(x.a,null,a.createElement(I.a,{tag:h.b,className:"text-dark",to:"/"},"Home")),a.createElement(x.a,null,a.createElement(I.a,{tag:h.b,className:"text-dark",to:"/login"},"Login")),a.createElement(x.a,null,a.createElement(I.a,{tag:h.b,className:"text-dark",to:"/404"},"NotFound")))))))}}class S extends a.PureComponent{render(){return a.createElement(a.Fragment,null,a.createElement(T,null),a.createElement(w.a,null,this.props.children))}}var j=Object(o.c)()(()=>a.createElement("div",null,a.createElement("h1",null,"Hello, world!"),a.createElement("p",null,"Welcome to your new single-page application, built with:"),a.createElement("ul",null,a.createElement("li",null,a.createElement("a",{href:"https://get.asp.net/"},"ASP.NET Core")," and ",a.createElement("a",{href:"https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx"},"C#")," for cross-platform server-side code"),a.createElement("li",null,a.createElement("a",{href:"https://facebook.github.io/react/"},"React")," and ",a.createElement("a",{href:"https://redux.js.org/"},"Redux")," for client-side code"),a.createElement("li",null,a.createElement("a",{href:"http://getbootstrap.com/"},"Bootstrap")," for layout and styling")),a.createElement("p",null,"To help you get started, we have also set up:"),a.createElement("ul",null,a.createElement("li",null,a.createElement("strong",null,"Client-side navigation"),". For example, click ",a.createElement("em",null,"Counter")," then ",a.createElement("em",null,"Back")," to return here."),a.createElement("li",null,a.createElement("strong",null,"Development server integration"),". In development mode, the development server from ",a.createElement("code",null,"create-react-app")," runs in the background automatically, so your client-side resources are dynamically built on demand and the page refreshes when you modify any file."),a.createElement("li",null,a.createElement("strong",null,"Efficient production builds"),". In production mode, development-time features are disabled, and your ",a.createElement("code",null,"dotnet publish")," configuration produces minified, efficiently bundled JavaScript files.")),a.createElement("p",null,"The ",a.createElement("code",null,"ClientApp")," subdirectory is a standard React application based on the ",a.createElement("code",null,"create-react-app")," template. If you open a command prompt in that directory, you can run ",a.createElement("code",null,"npm")," commands such as ",a.createElement("code",null,"npm test")," or ",a.createElement("code",null,"npm install"),".")));class _ extends a.PureComponent{render(){return a.createElement(a.Fragment,null,a.createElement("div",{className:"container"},a.createElement("div",{className:"row"},a.createElement("div",{className:"col-md-5 mx-auto"},a.createElement("div",{id:"first"},a.createElement("div",{className:"myform form "},a.createElement("div",{className:"logo mb-3"},a.createElement("div",{className:"col-md-12 text-center"},a.createElement("h1",null,"Login"))),a.createElement("form",{action:"",method:"post",name:"login"},a.createElement("div",{className:"form-group"},a.createElement("label",{htmlFor:"exampleInputEmail1"},"Email address"),a.createElement("input",{type:"email",name:"email",className:"form-control",id:"email","aria-describedby":"emailHelp",placeholder:"Enter email",onChange:e=>{this.props.setUserId(e.target.value)}})),a.createElement("div",{className:"form-group"},a.createElement("label",{htmlFor:"exampleInputEmail1"},"Password"),a.createElement("input",{type:"password",name:"password",id:"password",className:"form-control","aria-describedby":"emailHelp",placeholder:"Enter Password",onChange:e=>{this.props.setPassword(e.target.value)}})),a.createElement("div",{className:"form-group"},a.createElement("p",{className:"text-center"},"By signing up you accept our ",a.createElement("a",{href:"#"},"Terms Of Use"))),a.createElement("div",{className:"col-md-12 text-center "},a.createElement("button",{type:"button",className:"btn btn-block btn-primary btn-lg tx-tfm",onClick:()=>{this.props.post()}},"Login")),a.createElement("div",{className:"form-group"},a.createElement("p",{className:"text-center"},"Don't have account? ",a.createElement("a",{href:"#",id:"signup"},"Sign up here"))))))))))}}var C=Object(o.c)(e=>e.loginUser,p)(_);var U=Object(o.c)()(()=>a.createElement("div",{className:"container"},a.createElement("div",{className:"row"},a.createElement("div",{className:"col-md-12"},a.createElement("div",{className:"error-template"},a.createElement("h1",null,"Oops!"),a.createElement("h2",null,"404 Not Found"),a.createElement("div",{className:"error-details"},"Sorry, an error has occured, Requested page not found!"),a.createElement("div",{className:"error-actions"},a.createElement("a",{href:"http://www.jquery2dotnet.com",className:"btn btn-primary btn-lg"},a.createElement("span",{className:"glyphicon glyphicon-home"}),"Take Me Home "),a.createElement("a",{href:"http://www.jquery2dotnet.com",className:"btn btn-default btn-lg"},a.createElement("span",{className:"glyphicon glyphicon-envelope"})," Contact Support "))))))),P=(n(57),()=>r.a.createElement(h.a,null,r.a.createElement(S,null,r.a.createElement(g.d,null,r.a.createElement(g.b,{path:"/login",component:C}),r.a.createElement(g.b,{path:"/404",component:U}),r.a.createElement(v,{path:"/",component:j}),r.a.createElement(g.a,{to:"/login"})))));const D=Boolean("localhost"===window.location.hostname||"[::1]"===window.location.hostname||window.location.hostname.match(/^127(?:\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$/));function L(e){navigator.serviceWorker.register(e).then(e=>{e.onupdatefound=()=>{const t=e.installing;t.onstatechange=()=>{"installed"===t.state&&(navigator.serviceWorker.controller?console.log("New content is available; please refresh."):console.log("Content is cached for offline use."))}}}).catch(e=>{console.error("Error during service worker registration:",e)})}const R=document.getElementsByTagName("base")[0].getAttribute("href"),A=Object(c.a)({basename:R}),F=function(e,t){const n=[u.a,Object(d.a)(e)],a=Object(m.c)(Object(i.a)(Object(i.a)({},E),{},{router:Object(s.b)(e)})),r=[],l="undefined"===typeof window?null:window;return l&&l.__REDUX_DEVTOOLS_EXTENSION__&&r.push(l.__REDUX_DEVTOOLS_EXTENSION__()),Object(m.e)(a,t,Object(m.d)(Object(m.a)(...n),...r))}(A);l.render(a.createElement(o.a,{store:F},a.createElement(s.a,{history:A},a.createElement(P,null))),document.getElementById("root")),function(){if("serviceWorker"in navigator){if(new URL("",window.location.toString()).origin!==window.location.origin)return;window.addEventListener("load",()=>{const e="".concat("","/service-worker.js");D?function(e){fetch(e).then(t=>{const n=t.headers.get("content-type");404===t.status||n&&-1===n.indexOf("javascript")?navigator.serviceWorker.ready.then(e=>{e.unregister().then(()=>{window.location.reload()})}):L(e)}).catch(()=>{console.log("No internet connection found. App is running in offline mode.")})}(e):L(e)})}}()}},[[38,1,2]]]);
//# sourceMappingURL=main.cf01b7e3.chunk.js.map