import React, { useState, useEffect,useSessionStorage } from 'react';
import { Link } from 'react-router-dom';
import { GetJob } from '../Sevice/Job';
import { GetLocation } from '../Sevice/Location';

export default function Job() {

    let [joblist, setJobList] = useState([]);
    let [locationlist, setLocationList] = useState([]);
    let [location, setLocation] = useState(    localStorage.getItem('location') || null
    );

    const handleLocationChange = (location) => {
        debugger;
        setLocation(location);
        localStorage.setItem('location', location);

    }
    useEffect(() => {
        GetJob()
            .then(response => setJobList(response));
        GetLocation()
            .then(response => setLocationList(response));
    }, []);
    return (
        <>
            <select name="category" 
             value={location} onChange={event => handleLocationChange(event.target.value)}>

                {locationlist.map((x) =>
                    <option id={x.id} >{x.name} | {x.state}</option>
                )}
            </select>
            <ul>

                {joblist.map((x) =>
                    <li>
                        <Link to={{
                            pathname: "/jobdetail",
                            search: "?id=" + x.id,
                        }}>
                            <h2>{x.title}</h2>
                            {x.description}
                        </Link>

                    </li>
                )}
            </ul>
        </>
    );
}