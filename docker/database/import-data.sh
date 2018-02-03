#!/bin/bash
#wait for the SQL Server to come up
sleep 20s

#run the setup script to create the DB and the schema in the DB
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P L@rc0mb3 -d master -i /usr/local/bin/setup.sql

#import the data from the csv file
#/opt/mssql-tools/bin/bcp HeadHuntReview.dbo.Recruiters in "Recruiters.csv" -c -t',' -S localhost -U sa -P L@rc0mb3