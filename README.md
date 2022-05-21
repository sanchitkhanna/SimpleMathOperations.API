1. Install .Net 6 SDK and SQL Server Database
2. Install Docker Desktop
3. Enable Kubernetes on Docker Desktop
4. Create Database and Tables by executing sql files under SimpleMathOperationsAPI/Migrations/SQL folder.
5. Change the connection string in appsettings.Development.json according to your local machine
6. Create namespace using following kubectl command:
kubectl create namespace simplemathoperationsapi
7. Run AppRun.bat file.
8. Open Swagger page : http://localhost:8080/swagger/index.html