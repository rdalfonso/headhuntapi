#!/bin/bash
#wait for the SQL Server to come up
echo "Sleeping for a bit..."

sleep 20s

#run the setup script to create the DB and the schema in the DB
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P L@rc0mb3 -d master -i setup.sql