export const actionCreators = {
    post: () => (dispatch, getState) => {
        const appState = getState();
        console.log(appState);
        const form = new FormData();
        form.append('userId', appState.loginUser.user.userId);
        fetch("auth/default/Login", {
            method: "POST",
            body: form
        })
            .then(response => response.json())
            .then(data => {
                sessionStorage.setItem('authToken', JSON.stringify(data.authToken));
                dispatch({
                    type: "POST_LOGIN",
                    user: {
                        authToken: data.authToken,
                        userId: data.userId,
                        password: '',
                        isAuth: data.authToken ? true : false
                    },
                });
            })
            .catch(e => {
                /*發生錯誤時要做的事情*/
            })
    },

    setUserId: (userId) => (dispatch, getState) => {
        const appState = getState();
        dispatch({
            type: "SET_USERID",
            user: {
                authToken: '',
                userId: userId,
                password: appState.loginUser.user.password,
                isAuth: false
            }
        });
    },

    setPassword: (password) => (dispatch, getState) => {
        const appState = getState();
        dispatch({
            type: "SET_PASSWORD",
            user: {
                authToken: '',
                userId: appState.loginUser.user.userId,
                password: password,
                isAuth: false
            }
        });
    },

    logout: () => (dispatch, getState) => {
        sessionStorage.removeItem('authToken');
        dispatch({
            type: "USER_LOGOUT",
            user: {
                authToken: '',
                userId: '',
                password: '',
                isAuth: false
            }
        });
    }
};

export const reducer = (loginUser, incomingAction) => {
    if (loginUser === undefined) {
        return {
            user: {
                authToken: '',
                userId: '',
                password: '',
                isAuth: false
            }
        };
    }

    const action = incomingAction;
    console.log(action);

    switch (action.type) {
        case 'POST_LOGIN':
        case 'SET_USERID':
        case 'SET_PASSWORD':
        case 'USER_LOGOUT':
            return {
                user: action.user
            };
        default:
            return loginUser;
    }
};

