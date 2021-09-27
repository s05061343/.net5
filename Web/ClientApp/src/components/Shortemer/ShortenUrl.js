import { store } from 'react-notifications-component';
import { apiShortenUrl } from '../../utils/api.js';

export const actionCreators = {
    post: () => (dispatch, getState) => {
        const appState = getState();

        const json = { url: appState.shortemer.value.originalUrl }

        apiShortenUrl(json)
            .then(res => {
                console.log(res);
                const data = JSON.parse(res.request.response);
                console.log(data);
                if (res.status === 200) {
                    store.addNotification({
                        message: "縮網址完成",
                        type: "success",
                        insert: "top",
                        container: "top-right",
                        animationIn: ["animate__animated", "animate__fadeIn"],
                        animationOut: ["animate__animated", "animate__fadeOut"],
                        dismiss: {
                            duration: 5000,
                            onScreen: true
                        }
                    });
                    dispatch({
                        type: "POST",
                        value: {
                            originalUrl: appState.shortemer.value.originalUrl,
                            translationUrl: data.data
                        }
                    });
                }
            })
            .catch(err => {
                store.addNotification({
                    title: "產生失敗",
                    message: "縮網址產生失敗，請再試一次。",
                    type: "warning",
                    insert: "top",
                    container: "top-right",
                    animationIn: ["animate__animated", "animate__fadeIn"],
                    animationOut: ["animate__animated", "animate__fadeOut"],
                    dismiss: {
                        duration: 5000,
                        onScreen: true
                    }
                });
            });
    },

    setUrl: (originalUrl) => (dispatch, getState) => {
        const appState = getState();
        dispatch({
            type: "SET_URL",
            value: {
                originalUrl: originalUrl,
                translationUrl: ''
            }
        });
    },
};

export const reducer = (shortemer, incomingAction) => {
    if (shortemer === undefined) {
        return {
            value: {
                originalUrl: '',
                translationUrl: ''
            }
        };
    }

    switch (incomingAction.type) {
        case 'POST':
        case 'SET_URL':
            return {
                value: incomingAction.value
            };
        default:
            return shortemer;
    }
};

