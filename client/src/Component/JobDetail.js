import React, { useState, useEffect } from 'react';
import { GetJobById } from '../Sevice/Job';
import { useSearchParams } from 'react-router-dom'

export default function JobDetail(props) {
    const [searchParams, setSearchParams] = useSearchParams();
    const id = searchParams.get('id')
    let [job, setJob] = useState(null);
    useEffect(() => {
        GetJobById(id)
            .then(response => setJob(response));
    }, []);

    return (
        <div>
        {job!=null && 
        <>
            <div className='font-bold m-2'>{job.title}</div>
            <span >{job.description}</span>
        </>
        }
        </div>
    );
}