import logo from './logo.svg';
import './App.css';
import Job from './Component/Job';
import JobDetails from './Component/JobDetails';

function App() {
  return (
    <Layout >
      <img src={logo} alt="logo" />

      <Switch>
        <Route exact path="/">
          <Redirect to="/jobs" />
        </Route>
        <Route path="/jobs">
          <Job />
        </Route>
        <Route path="/jobsdetail">
          <JobDetails />
        </Route>
      </Switch>
    </Layout>

  );
}

export default App;
