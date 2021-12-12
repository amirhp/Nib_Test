import React, { useState, useEffect, useSessionStorage } from 'react';
import { Link } from 'react-router-dom';
import { GetJob } from '../Sevice/Job';
import { GetLocation } from '../Sevice/Location';

export default function Job() {

    let [joblist, setJobList] = useState([]);
    let [locationlist, setLocationList] = useState([]);
    let [location, setLocation] = useState(localStorage.getItem('location') || null
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
            <div className="flex pt-2 relative mx-auto text-gray-600">
                <input className="border-2 border-gray-300 bg-white h-10 px-5 pr-16 rounded-lg text-sm focus:outline-none"
                    type="search" name="search" placeholder="Search" />

                <select name="category" className='form-select block ml-2'
                    value={location} onChange={event => handleLocationChange(event.target.value)}>

                    {locationlist.map((x) =>
                        <option id={x.id} >{x.name} | {x.state}</option>
                    )}
                </select>
            </div>

<hr className="m-2"/>

            <div className="w-full bg-white rounded-lg shadow-lg">
                <ul className="divide-y-2 divide-gray-100">
                    {joblist.map((x) =>
                        <li className="p-3 hover:bg-blue-600 hover:text-blue-200">
                            <Link to={{
                                pathname: "/jobdetail",
                                search: "?id=" + x.id,
                            }}>
                                <p className='p-2 font-bold'>{x.title}</p>
                                {x.description}  ...
                            </Link>
                        </li>
                    )}

                </ul>
            </div>



        </>
    );
}
