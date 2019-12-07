db.createUser({
  user: 'root',
  pwd: 'SGEMongo2019!',
  roles: [
    {
      role: 'readWrite',
      db: 'admin'
    },
    {
      role: 'readWrite',
      db: 'SGEdb'
    }
  ]
});
