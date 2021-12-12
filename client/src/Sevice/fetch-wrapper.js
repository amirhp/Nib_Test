
export const fetchWrapper = {
    get,
    post,
    put,
    delete: _delete
}

function get(url) {
    const requestOptions = {
        method: 'GET',
        mode: 'cors',
        headers: authHeader(url)
    };
    return fetch(url, requestOptions).then(handleResponse);
}

function post(url, body) {
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json', ...authHeader(url) },
        body: JSON.stringify(body)
    };
    return fetch(url, requestOptions).then(handleResponse);
}

function put(url, body) {
    const requestOptions = {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json', ...authHeader(url) },
        body: JSON.stringify(body)
    };
    return fetch(url, requestOptions).then(handleResponse);    
}

function _delete(url) {
    const requestOptions = {
        method: 'DELETE',
        headers: authHeader(url)
    };
    return fetch(url, requestOptions).then(handleResponse);
}

// helper functions

function authHeader(url) {
    // return auth header cases like jwt
        return {};
}

function handleResponse(response) {
    return response.text().then(text => {
        const data = text && JSON.parse(text);
        
        if (!response.ok) {
            if ([401, 403].includes(response.status)) {
                // should logout if 401 Unauthorized or 403 Forbidden response returned from api
            }
            const error = getErrorMessage(data,response.statusText);// && data.message) || response.statusText;
            return Promise.reject(error);
        }

        return data;
    });
}

function getErrorMessage(data, response)
{
    if(data.meesage)
        return data.meesage;

    if(data.errors)
    {
        let meesage='Following error has occured:\n';
        for(let error in data.errors)
        {
            meesage+=`:${error}:\n${data.errors[error].map(x=>`${x}\n`)}`
        }
        return meesage;
    }
    return response;
}