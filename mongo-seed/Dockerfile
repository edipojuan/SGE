FROM mongo

COPY init.json /init.json
CMD mongoimport --host mongodb --port 27017 --db admin --collection Eventos --authenticationDatabase admin --username root --password "SGEMongo2019!" --type json --file /init.json --jsonArray