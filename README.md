## HeadHuntReview

### Install
```
docker compose up
```

This project uses three docker containers:
- db (SQL Server database with start-up seed data)
- web (.NET Core API project that pulls from latest image on docker hub: feltonvillain/headhuntapi:latest)
- site (Angular 4 CLI project that pulls from latest image on docker hub: feltonvillain/headhuntreview:latest)

As I push builds the images are automatically updated via the deployment pipeline.
