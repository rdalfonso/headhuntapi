FROM mcr.microsoft.com/mssql/server:2017-latest

# Create app directory
RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app

# Bundle app source
COPY . /usr/src/app

RUN chmod +x /usr/src/app/entrypoint.sh
RUN chmod +x /usr/src/app/import-data.sh

CMD /bin/bash ./entrypoint.sh ; sleep infinity