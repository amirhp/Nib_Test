import './App.css';

import Layout from './Component/Layout';
import Job from './Component/Job';
import JobDetails from './Component/JobDetails';

import {
  Routes ,
  Route,
  Navigate
} from "react-router-dom";

function App() {
  console.log(process.env);
  return (
<>
     <Routes >
        <Route exact path="/" element={<Job />} />

        <Route path="/jobs" element={<Job />} />

        <Route path="/jobsdetail" element={<JobDetails />}/>

      </Routes > 
</>
  );
}

export default App;
