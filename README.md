# Coding Portfolio – Juuso Savolainen

This repository contains the source code for my personal developer portfolio, built with **Blazor WebAssembly** and deployed using **GitHub Pages** with automated CI/CD (coming soon).

The site is designed as a single-page application with smooth navigation, responsive layout, and bilingual support (English / Finnish). 
The site showcases my skills, projects, and technical stack, and serves as a central hub for presenting my work.

**Live site:**  
https://juusosav.github.io/CodingPortfolio/


---


# Overview

This portfolio is a single-page application (SPA) built with modern .NET technologies.  
It emphasizes clean architecture, localization support, and a professional deployment workflow.

Key goals of the project:
- Present projects and technical experience clearly
- Demonstrate real-world Blazor WebAssembly usage
- Showcase CI/CD and static hosting best practices

---

## Technology Stack

- **Blazor WebAssembly (.NET 8)**
- **C#**
- **ASP.NET Core**
- **Bootstrap 5**
- **JavaScript Interop**
- **Localization (EN / FI)**
- **GitHub Pages**
- **GitHub Actions (CI/CD)**

---

## Features

- Single-page application with client-side routing
- English and Finnish localization with runtime language switching
- Responsive design for desktop and mobile
- Project showcase section
- Contact section with EmailJS integration
- Automated deployment pipeline

---

## Project Structure

```bash
CodingPortfolio/
│
├─ CodingPortfolioWebsite/
│  ├─ Pages/                 # Blazor pages (About, Projects, etc.)
│  ├─ Components/            # Reusable UI components
│  ├─ Layout/                # Layouts and navigation
│  ├─ wwwroot/               # Static assets (CSS, JS, images)
│  ├─ Program.cs             # Application entry point
│  └─ CodingPortfolioWebsite.csproj
│
├─ .github/
│  └─ workflows/
│     └─ deploy.yml          # GitHub Pages deployment workflow
│
└─ README.md
```

## Development Setup

Prerequisites

- **.NET SDK 8.0 or newer**
- **Git**
- **A modern web browser (Chrome, Edge, Firefox)**

---

## Run Locally

Clone the repository:

```bash
git clone https://github.com/juusosav/CodingPortfolio.git
cd CodingPortfolio
```

Run the Blazor WebAssembly project:

```bash
dotnet run --project CodingPortfolioWebsite
```

The application will be available at:

```bash
https://localhost
```

---

# Deployment

The application is deployed as a static site using GitHub Pages.

Deployment is fully automated via GitHub Actions (coming soon).
No manual publishing or branch management is required after setup.

---

# Workflow Summary

- **Development is done on the main branch**
- **On every push to main:**
  - The Blazor WebAssembly app is built in Release mode
  - Static files are generated using dotnet publish
  - The contents of the published wwwroot folder are deployed to the gh-pages branch
- **GitHub Pages serves the site from the gh-pages branch**

---

# Localization

The application supports multiple languages using:

- **Microsoft.Extensions.Localization**
- **Resource files (.resx)**

# Supported languages

- **English**
- **Finnish**

The selected language is stored in browser storage and persists between sessions.

---

# License

This project is provided for portfolio and demonstration purposes.

You are welcome to explore the code and structure, but please do not reuse the design, assets, or content without permission.

---

# Author

**Juuso Savolainen**



