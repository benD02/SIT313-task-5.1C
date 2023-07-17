import React from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import HomePage from './HomePage';
import NewJobPage from './NewJobPage';

function App() {
  return (
    <Router>
      <div>
        {/* Navbar */}
        {/* Other content */}

        {/* Routing */}
        <Switch>
          {/* Homepage */}
          <Route exact path="/">
            <HomePage />
          </Route>

          {/* New Job Page */}
          <Route path="/find-jobs">
            <NewJobPage />
          </Route>
        </Switch>

        {/* Footer */}
      </div>
    </Router>
  );
}

export default App;
