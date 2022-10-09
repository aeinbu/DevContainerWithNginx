# DevContainerSample
## A sample setup of a development container consisting of:
- A aspnetcore and react container
- A Nginx container to serve the aspnetcore webapi and the react web app on the same endpoint (So no need for CORS)

## On creation this container will:
- Start the react application dev server

## To test this container
- Start debugging the aspnetcore webapi by pressing press F5
- On your computer running docker, navigate to http://locahost:8081 (for the react development server) or to http://localhost:8080 (for the built  react app in frontend/build/) 
  Run `npm run build` to build

## Prerequisites
You will ONLY need [Docker Desktop](https://www.docker.com/products/docker-desktop/) and [Visual Studio Code](https://code.visualstudio.com) with the [Remote Containers extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers)  to start using the development container.

There is NO NEED TO INSTALL ANY OTHER TOOLS OR FRAMEWORKS to use this development container!
