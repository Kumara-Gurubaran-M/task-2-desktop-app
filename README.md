# Project Title: Submission Manager

## Overview

Submission Manager is a Windows Forms application developed in Visual Basic .NET. The application allows users to create, view, edit, search, and delete submissions. Each submission includes details such as name, email, phone number, GitHub link, and elapsed time.

## Features

1. **Main Form (Form1)**
   - Launches other forms using buttons and keyboard shortcuts.
   - Keyboard Shortcuts:
     - `Ctrl + V` to view submissions.
     - `Ctrl + N` to create a new submission.
     - `Ctrl + L` to search for submissions.

2. **New Submission Form (Form2)**
   - Allows users to create a new submission with validation for inputs.
   - Keyboard Shortcuts:
     - `Ctrl + T` to toggle the stopwatch.
     - `Ctrl + S` to submit the form.
   - Validates input fields for name, email, phone number, and GitHub link.
   - Submits data to a backend server.

3. **View Submissions Form (Form3)**
   - Displays submissions fetched from a backend server.
   - Allows navigation through submissions using buttons and keyboard shortcuts.
   - Keyboard Shortcuts:
     - `Ctrl + N` for next submission.
     - `Ctrl + P` for previous submission.
     - `Ctrl + E` to edit the current submission.
     - `Ctrl + D` to delete the current submission.

4. **Edit Submission Form (Form4)**
   - Allows users to edit a selected submission.
   - Updates the submission on the backend server.
   - Includes a stopwatch to track the elapsed time.

5. **Search Submissions Form (Form5)**
   - Allows users to search for submissions by email.
   - Displays results in a DataGridView.

## Code Structure

### Main Form (Form1)

- **New():** Initializes the form and sets KeyPreview to True.
- **btncreatenewsubmission:** Opens Form2.
- **btnviewsubmission:** Opens Form3.
- **btnsearchform_Click:** Opens Form5.
- **Form1_KeyDown:** Handles keyboard shortcuts for viewing, creating, and searching submissions.

### New Submission Form (Form2)

- **New():** Initializes the form and sets KeyPreview to True.
- **Form2_Load:** Starts a timer when the form loads.
- **btntogglestopwatch:** Toggles the stopwatch.
- **btnsubmit:** Validates inputs and submits the form data to the backend server.
- **ValidateInputs:** Validates the input fields.
- **Timer1_Tick:** Updates the elapsed time display.
- **Form2_KeyDown:** Handles keyboard shortcuts for toggling the stopwatch and submitting the form.

### View Submissions Form (Form3)

- **New():** Initializes the form, sets KeyPreview to True, loads submissions from the server, and displays the first submission.
- **LoadSubmissions:** Fetches submissions from the backend server.
- **DisplaySubmission:** Displays a submission based on the current index.
- **Button1_Click:** Navigates to the next submission.
- **Button2_Click:** Navigates to the previous submission.
- **Form3_KeyDown:** Handles keyboard shortcuts for navigation, editing, and deleting submissions.
- **btndelete_Click:** Deletes the current submission from the backend server.
- **editbtn_Click:** Opens Form4 for editing the current submission.

### Edit Submission Form (Form4)

- **New(Submission):** Initializes the form with a submission, loads submission data, and starts a timer.
- **LoadSubmissionData:** Loads submission data into the form fields.
- **FormatTime:** Formats the elapsed time string.
- **editsubmit_Click:** Updates the submission on the backend server.
- **CalculateTotalTime:** Calculates the total elapsed time.
- **RemoveMilliseconds:** Removes milliseconds from the elapsed time string.
- **Timer1_Tick:** Updates the elapsed time display.
- **btntimer_Click:** Toggles the stopwatch.

### Search Submissions Form (Form5)

- **New():** Initializes the form, loads submissions from the server, and sets up the DataGridView.
- **LoadSubmissions:** Fetches submissions from the backend server.
- **SetupDataGridView:** Configures the DataGridView columns and binds the submissions list.
- **btnsearch_Click:** Searches for submissions by email.
- **searchbar_TextChanged:** Clears the DataGridView when the search bar text changes.

### Submission Class

Represents a submission with the following properties:
- `name`
- `email`
- `phone`
- `githubLink`
- `elapsedTime`
- `timestamp`

## Dependencies

- Newtonsoft.Json for JSON serialization and deserialization.
- System.Net.Http for HTTP client operations.

## Running the Application

1. Ensure you have the necessary backend server running at `http://localhost:5000`.
2. Build and run the application using Visual Studio or another compatible IDE.

## Notes

- The application assumes a backend server is running at `http://localhost:5000` to handle HTTP requests for submission data. Ensure the backend server is configured and running before using the application.
