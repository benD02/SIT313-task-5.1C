import React, { useState } from 'react';

const NewJobPage = () => {
  const [jobType, setJobType] = useState('');
  const [jobTitle, setJobTitle] = useState('');
  const [jobDescription, setJobDescription] = useState('');

  const handleJobTypeChange = (event) => {
    setJobType(event.target.value);
  };

  const handleJobTitleChange = (event) => {
    setJobTitle(event.target.value);
  };

  const handleJobDescriptionChange = (event) => {
    setJobDescription(event.target.value);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    // Handle the submission of the job form
    // Save the job information to a database or perform any necessary actions
    console.log('Job submitted:', { jobType, jobTitle, jobDescription });
  };

  return (
    <div>
      <h2>New Job</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label htmlFor="jobType">Job Type:</label>
          <select id="jobType" value={jobType} onChange={handleJobTypeChange}>
            <option value="">Select Job Type</option>
            <option value="freelance">Freelance</option>
            <option value="employment">Employment</option>
          </select>
        </div>
        {jobType === 'freelance' && (
          <div>
            <label htmlFor="jobTitle">Job Title:</label>
            <input type="text" id="jobTitle" value={jobTitle} onChange={handleJobTitleChange} />
          </div>
        )}
        {jobType === 'employment' && (
          <div>
            <label htmlFor="jobDescription">Job Description:</label>
            <textarea id="jobDescription" value={jobDescription} onChange={handleJobDescriptionChange} />
          </div>
        )}
        <button type="submit">Submit</button>
      </form>
    </div>
  );
};

export default NewJobPage;
