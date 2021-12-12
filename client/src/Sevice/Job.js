import { fetchWrapper } from './fetch-wrapper';

function GetJob()
{
    var jobUrl = process.env.REACT_APP_Server_Address+'/job/';
    return fetchWrapper.get(jobUrl);    
}


function GetJobById(id)
{
    var jobUrl = process.env.REACT_APP_Server_Address+'/job/'+id;
    return fetchWrapper.get(jobUrl);
}

export  {GetJob,GetJobById};