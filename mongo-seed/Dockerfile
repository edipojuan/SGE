FROM mongo

COPY init.json /init.json
CMD mongoimport --host mongodb --db SGEDb --collection Eventos --authenticationDatabase admin --username root --password "SGEMongo2019!" --type json --file /init.json --jsonArray