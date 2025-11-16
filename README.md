
---
# 🚀 BlogStore_NTIER_AI
## ASP.NET Core • N-Layer Architecture • AI Toxic Comment Moderation System

**BlogStore_NTIER_AI** is built on ASP.NET Core with an **N-Layer Architecture** structure,
equipped with **AI-powered (ToxicBERT)** comment moderation, **SEO-friendly**, **Identity-based author management**,
**modular ViewComponent UI** and **dashboard** interface, forming a **real-world professional blog platform**.

The project was developed within **M&Y Yazılım Eğitim Akademisi Danışmanlık** under the mentorship of **Murat Yucedag**.
## 

🧩 Platform Modules

**Section** | **Description**
---------|----------
🌐 **Blog (Frontend)** | Article listing, categories, author pages, comment system
🛠 **Dashboard (Author Panel)** | Article CRUD, profile, statistics, toxic comment list


## 🌟Key Functionalities

✍️ Create, update, delete articles

🏷 Category-based content filtering system

💬 AI-based toxic comment moderation

🔐 ASP.NET Core Identity Authentication

🌐 SEO-Friendly Slug URL

📊 ApexCharts Dashboard

👤 Author profile management, data update and password change

🧩 Modular ViewComponent UI

🎨 Blogy + Flexy Admin Template UI

🔁 AJAX-based Asynchronous Comment System

- **Full N-Tier Architecture (Entity – DAL – Business – UI**  

---

## 🏗 Layihə Arxitekturası (N-Tier)

```text
BlogStore_NTIER_AI
│
├── EntityLayer         → Entity modelləri (Fluent API)
├── DataAccessLayer     → EF Core, Repository Pattern, Context
├── BusinessLayer       → Service, Manager, Validation, DI
└── PresentationLayer   → MVC, Controllers, Views, Components
```




## 🧱 1️⃣ Entity Layer

- Stores project data models

- Configured using Fluent API


## 💾 2️⃣ DataAccess Layer (EF Core + Repository Pattern)

- CRUD + Custom LINQ Query methods

- Special toxic filtering methods implemented 

## ⚙️ 3️⃣ Business Layer (Service + Manager + DI)

- Business logic is executed in this layer

- Dependency Injection → ContainerExtensions is provided

- Acts as a bridge between DataAccess and Presentation

---

## 🤖 AI-Powered Toxic Comment Moderation (ToxicBERT)

### 🔬 Analysis Flow

1️⃣ User writes a comment
2️⃣ TR → EN (Helsinki-NLP/opus-mt-tr-en) is translated
3️⃣ Sent to the ToxicBERT model
4️⃣ Score + Label result is received
5️⃣ Classified according to the rule and applied to the UI

Score > 0.25 → 🚫 Toxic (hidden on the UI, visible only in the Admin panel)
Score ≤ 0.25 → ✔️ Clean (displayed on the Frontend)


### 📌 AI results stored in DB

- `IsToxic`
- `ToxicityScore`
- `ToxicLabel`
- `IsValid`

### 🔧 Main methods

- `GetNonToxicCommentsByArticle()`
- `GetToxicComments()`
- `GetLast3CommentsByArticle()`

---


## 4.🎨 Presentation Layer (MVC + ViewComponents)

| UI Section | Description |
|------------|---------|
| **Blog UI (Blogy)** | Articles, categories, author profiles |
| **Author Panel (Flexy Admin)** | Dashboard, CRUD, profile, toxic comment list |

---

### 🔐 Security & Identity Module

The login and registration system is built using ASP.NET Core Identity.
Users can register with Name, Surname, Email and Username information.
Login is performed using Cookie Authentication.



---

### 🔁 AJAX Comment System

- Comments are submitted without page refresh

- Warning is shown if login is required

---

### 🌐 SEO Slug Example

/articles/secure-coding-principles


---

## 📊 Dashboard Visual Analytics (ApexCharts)

- 📈 Bar Chart → Number of articles by category

- 🍩 Donut Chart → Category distribution

- 📝 List of latest articles and latest comments

---

## 🗂 Project Pages

### 🔧 Admin Panel
- Dashboard  
- Article List (Card UI)  
- Add New Article  
- Profile Settings  
- Toxic Comment List
- 


### 🌍 Blog UI
- Home  
- Categories  
- Authors  
- Comments  
- Login / Register  

---

## 🧩 Clean Architecture Benefits

- Extension-based Dependency Injection  
- Minimal və təmiz `Program.cs`  
- Reusable UI Components  

---



### Images

![Screenshot 2025-11-16 032738](https://github.com/user-attachments/assets/de18e167-cdb4-4eb4-9a9c-cddec85c0d1c)
![Screenshot 2025-11-16 032756](https://github.com/user-attachments/assets/153c69d7-a839-4bf0-873e-4a2eb1190c47)
![Screenshot 2025-11-16 042913](https://github.com/user-attachments/assets/483adc10-853a-4a09-a312-83788a73514d)
![Screenshot 2025-11-16 043702](https://github.com/user-attachments/assets/c68adf83-176c-47de-a98e-d6c8dd9265aa)
![Screenshot 2025-11-16 042029](https://github.com/user-attachments/assets/8f506337-b71e-4a5e-8716-98569b3c2bec)
![Screenshot 2025-11-16 043557](https://github.com/user-attachments/assets/03f14717-e97e-4f07-b134-bc9ad3d85e45)
![Screenshot 2025-11-16 043625](https://github.com/user-attachments/assets/ed61f63c-a34c-448b-9f3d-7a2caaa5726d)
![Screenshot 2025-11-16 043639](https://github.com/user-attachments/assets/01cc543f-039c-4d96-8a4e-8fafc76b6335)
<img width="1093" height="677" alt="Screenshot 2025-11-16 042407" src="https://github.com/user-attachments/assets/de64cb33-d3e3-453e-b4bd-a23320cbcf86" />
![Screenshot 2025-11-16 042341](https://github.com/user-attachments/assets/37f01f31-c3aa-4769-abc6-7d70f6379ab7)
![Screenshot 2025-11-16 042533](https://github.com/user-attachments/assets/2204fa9b-b040-42fc-aed4-dba36ae3ccba)
![Screenshot 2025-11-16 042552](https://github.com/user-attachments/assets/c9e0cb35-915c-4f18-8a06-ddbd73d2b1eb)
![Screenshot 2025-11-16 043905](https://github.com/user-attachments/assets/142a2daf-af09-47ea-99ff-feeb62e146ae)
![Screenshot 2025-11-16 044058](https://github.com/user-attachments/assets/a10e2ec7-464e-47b2-bbc9-c9fb2ff21bee)
![Screenshot 2025-11-16 044030](https://github.com/user-attachments/assets/3755730a-eb8c-418b-a64d-82c6d300e10e)
![Screenshot 2025-11-16 044012](https://github.com/user-attachments/assets/8e002c9c-f8c5-4626-9496-6783a6bc23e7)
![Screenshot 2025-11-16 043958](https://github.com/user-attachments/assets/e5e1d1ec-f237-40fc-b385-d56548abdcb0)
![Screenshot 2025-11-16 043939](https://github.com/user-attachments/assets/6c77e807-343c-4c16-9053-a2bd4f1d85cc)
![Screenshot 2025-11-16 033328](https://github.com/user-attachments/assets/f576ba9b-0201-44f0-9815-d76ddf7f5ab4)
![Screenshot 2025-11-16 033416](https://github.com/user-attachments/assets/694a8979-9f0c-4ed8-b2c0-1b67886d8cea)
![Screenshot 2025-11-16 044300](https://github.com/user-attachments/assets/abc75600-d8eb-49d4-9459-3ef6aefb5ae9)
![Screenshot 2025-11-16 044351](https://github.com/user-attachments/assets/990e5c53-09e9-43fe-a2ee-cc6b88feec42)
![Screenshot 2025-11-16 045349](https://github.com/user-attachments/assets/980d424f-9989-4846-be7f-857904cee824)
![Screenshot 2025-11-16 055858](https://github.com/user-attachments/assets/d716eaa3-96a9-4b4f-a5ab-1c3af695d4e8)
![Screenshot 2025-11-16 060005](https://github.com/user-attachments/assets/617e333b-9207-4621-9f78-8b6560eb9326)
![Screenshot 2025-11-16 042649](https://github.com/user-attachments/assets/e2e4c086-0f64-4b7c-91ae-8c1fd62b4a39)
![Screenshot 2025-11-16 040347](https://github.com/user-attachments/assets/3fcac6c3-1f68-4b00-a8f5-0c60977f2ebc)
![Screenshot 2025-11-16 040251](https://github.com/user-attachments/assets/32093086-d9bc-450a-b36a-a669c04a696a)
![Screenshot 2025-11-16 035158](https://github.com/user-attachments/assets/b181979f-c4fa-4d5b-962b-75ef9ad99463)




