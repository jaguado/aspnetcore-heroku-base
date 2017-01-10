# aspnetcore-heroku-base

AspNetCore ready to run on heroku.     

## Quick start guide ##

> heroku create --buildpack http://github.com/noliar/dotnet-buildpack.git  
> git clone https://github.com/jaguado/aspnetcore-heroku-base.git .    
> git remote rm heroku  
> heroku git:remote -a [heroku-app-name]  
> git push heroku master  
> heroku open

**Example app:**  
https://dotnet.jamtech.cl  