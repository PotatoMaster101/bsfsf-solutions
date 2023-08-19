# Section 07
1. Create DB migration: `dotnet ef migrations add InitialCreate --project Section07 --startup-project Section07 --context AuthDbContext`
2. Run Postgres DB: `docker compose -f Section07/docker-compose.yml up -d`
3. Create admin user using email: `admin@test.com`
4. Create employee user using email: `emp@test.com`
5. Visit `/PromoteUser` to promote admin and employee users
