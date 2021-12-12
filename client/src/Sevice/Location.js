import { fetchWrapper } from './fetch-wrapper';

function GetLocation()
{
    var locationUrl = process.env.REACT_APP_Server_Address+'/location/';
    return fetchWrapper.get(locationUrl);    
}

export  {GetLocation};