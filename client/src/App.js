import './App.css';

import Layout from './Component/Layout';
import Job from './Component/Job';
import JobDetail from './Component/JobDetail';

import {
  Routes ,
  Route,
  Navigate
} from "react-router-dom";

function App() {
  console.log(process.env);
  return (
<>

<Layout>
</Layout>

     <Routes >
        <Route exact path="/" element={<Job />} />

        <Route path="/jobs" element={<Job />} />
        
        <Route path="/jobdetail" element={<JobDetail />}/>

      </Routes > 
</>
  );
}

export default App;
