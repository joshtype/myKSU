# myKSU Prototype - Group 8 Software

## Overview
Welcome to **myKSU**, a standalone and portable .NET C# prototype for myKSU's mobile system.

## Purpose
Complex schedules, coursework, financial planning, degree progress, everyday life on- and off-campus... Students have a lot to juggle. 
myKSU is a user-friendly, mobile solution to provide Kennesaw State University students with on-demand access to important information
and administrative services using a familiar interface with KSU branding. myKSU will drive enrollment rates, reduce staff workload, and
promote student independence and success while meeting organizational goals and adhering to institutional policies. It is time to bring
KSU administrative services into the modern tech ecosystem and place more control of their educational journey into the hands of those 
most invested.

## Features
- **myCourses** – View enrolled courses
- **mySchedule** – View current class schedule
- **myRegistration** – Catalog filtering, course enrollment, viewing recommended courses based on standing, major, and previous courses
- **myPayments** – View payment history and pay balances
- **myProfile** – Personal student information
- **Hooty (Digital Advisor Chatbot)** – Available from every screen except Login to answer queries related to student data like id, major, gpa, 
enrolled courses, and completed courses

## Installation & Setup
### 1. Unzip the Folder
- Locate the downloaded **myKSU.zip** file.
- Right-click and select **Extract All** or use your preferred extraction tool.

### 2. Find & Launch `myKSU.exe`
- Open the extracted **myKSU** folder.
- Double-click `myKSU.exe` to start the application.

## System Requirements
- **OS:**   Windows 10 or later
- **RAM:**  2GB minimum            
- **Disk:** 100MB+ free disk space 

## Not Required
- .NET runtime (app is standalone and portable)
- Network connection 

## Disabled for prototype
- Local storage access for uploading myProfile image
- JSON files are not rewritten to maintain testing environment.
- Payment Gateway API interfacing for myCharges payments

## Storage
- Prototype leverages JSON files to store key system data
- Production will migrate from local storage to a cloud-based relational database

## Important Notice
⚠ **Do NOT move or rename any files or folders within the myKSU directory!**  
The application depends on its **predefined directory structure**. Moving or renaming files may **cause errors** or prevent the app from running properly.

## Trade-offs of WinForms for a Mobile App Prototype
Using **WinForms** for prototyping a mobile app has some advantages and trade-offs:
### Pros
- Rapid development with existing Windows UI components
- Minimal setup required for functionality
- Faster prototyping for desktop environments
### Cons
- **Not optimized for mobile:** Lacks native touchscreen support and responsive UI elements.
- **Design constraints:** UI adjustments needed for true mobile experiences.
- **Dated UI controls:** WinForms controls can appear dated compared to more modern frameworks.

## Support
For assistance, contact **Group 8 Software** or refer to additional documentation.