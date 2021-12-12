import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { GetJob } from '../Sevice/Job';

export default function Job() {

    let [joblist, setJobList] = useState([]);
    debugger;
    useEffect(() => {
        GetJob()
            .then(response => setJobList(response));
    }, []);

    return (
        <>
            <ul>

                {joblist.map((x) =>
                    <li>
                        <a href='#'>
                        <h2>{x.title}</h2>
                        {x.description}
                        </a>
                    </li>
        )}
        </ul>
        </>
    );
}