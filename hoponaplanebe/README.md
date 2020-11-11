An API that uses an external Countries API to give a user information on a location
if they request information about it.

To create a user:
POST localhost:1982/users/user
{
    "username": "Tom",
    "password" : "Coffee123"
}

To get all users (not accessible from the front end):
GET localhost:1982/users/all

To get a user by ID:
GET localhost:1982/users/{id} <-- if user exists

To change a user's info:
PUT localhost:1982/users/user/{id}
{
    "username": "James",
    "password" : "Coffee123"
}

To delete a user:
DELETE localhost:1982/users/user/{id}