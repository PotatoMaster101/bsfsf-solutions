# Section 08
1. Create DB migration: `dotnet ef migrations add InitialCreate --project Section08.DataAccess --startup-project Section08 --context AppDbContext`
2. Run Postgres DB: `docker compose -f Section08/docker-compose.yml up -d`
