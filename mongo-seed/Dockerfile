FROM mongo

COPY init.json /init.json
CMD mongoimport --host mongodb --db SGEDb --collection Eventos --type json --file /init.json --jsonArray