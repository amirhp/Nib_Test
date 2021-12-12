import './App.css';
import Layout from './Component/Layout';
import Job from './Component/Job';
import JobDetail from './Component/JobDetail';
import { Link } from 'react-router-dom';

import {
  Routes,
  Route,
  Navigate
} from "react-router-dom";

function App() {
  console.log(process.env);
  return (
    <div className="h-screen pb-14 bg-right bg-cover" >
      <div className="w-full container mx-auto p-6">
        <div className="w-full flex items-center justify-between">
          <a className="flex items-center text-indigo-400 no-underline hover:no-underline font-bold text-2xl lg:text-4xl" href="#">
            NIB
          </a>
          <div className="flex w-1/2 justify-end content-center">
            <a className="inline-block text-blue-300 no-underline hover:text-indigo-800 hover:text-underline text-center h-10 p-2 md:h-auto md:p-4" data-tippy-content="@twitter_handle" href="https://twitter.com/intent/tweet?url=#">
              <Link to={{
                pathname: "/jobs",
              }}>
                Job
              </Link>
            </a>
            <a className="inline-block text-blue-300 no-underline hover:text-indigo-800 hover:text-underline text-center h-10 p-2 md:h-auto md:p-4 " data-tippy-content="#facebook_id" href="https://www.facebook.com/sharer/sharer.php?u=#">
              Main Website
            </a>
          </div>

        </div>

      </div>

      <div className="container  px-6 mx-auto flex flex-wrap flex-col md:flex-row items-center">
        <h1 className="my-4 text-2xl md:text-5xl text-purple-800 font-bold leading-tight text-center md:text-left slide-in-bottom-h1">Find your dream job in NIB</h1>

        <div className="flex flex-col w-full xl:w-2/5 justify-center lg:items-start overflow-y-hidden">
        </div>

        <div className="w-full xl:w-3/5 py-6 overflow-y-hidden">
          <Routes >
            <Route exact path="/" element={<Job />} />

            <Route path="/jobs" element={<Job />} />

            <Route path="/jobdetail" element={<JobDetail />} />

          </Routes >
        </div>

        <div className="w-full pt-16 pb-6 text-sm text-center md:text-left fade-in">
          <a className="text-gray-500 no-underline hover:no-underline" href="#">&copy; Amir Nib Test 2021</a>
        </div>

      </div>
    </div>
  );
}

export default App;
