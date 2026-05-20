# BERS - Barangay Emergency Response System

A Windows Forms desktop application for barangay emergency management built with C# .NET and MS Access database.

## Features

### Resident Features
- Sign up / Login
- Report emergency with map location picker
- Select emergency type and barangay
- Track report status and view agency responses
- View emergency contacts directory

### Agency Features (Police, Fire, Ambulance, Disaster)
- Login with role-based access
- View filtered reports by emergency type
- Update report status (Pending, Responding, Resolved)
- Send response messages to residents
- View report location on map

### Admin Features
- Manage residents (Add, Update, Delete, Search)
- View analytics dashboard with charts
- Manage emergency contacts

## Technology Stack

- **Language:** C# .NET Framework 4.7.2
- **UI Framework:** Windows Forms
- **Database:** MS Access (.accdb)
- **Map Integration:** WebView2, Leaflet.js, CARTO Basemaps
- **Analytics:** Chart control (Pie, Bar, Line charts)

## Database Setup

1. Create an MS Access database named `Agency.accdb`
2. Create a folder named `Database` in `bin\Debug\`
3. Place `Agency.accdb` in `bin\Debug\Database\`

## How to Run

1. Clone this repository
2. Open the solution in Visual Studio
3. Restore NuGet packages
4. Build and run (Ctrl + Shift + B)

## Login Credentials

| Role      | Username     | Password      |
|------     |----------    |----------     |
| Admin     | admin        | admin123      |
| Police    | police123    | policepass    |
| Fire      | fire123      | firepass      |
| Ambulance | ambulance123 | ambulancepass |
| Disaster  | disaster123  | disasterpass  |
| Resident  | (Create your own account)    |
