# Étape 1 : Utiliser l'image Node 22 pour builder l'application
FROM node:22 AS build
WORKDIR /app
COPY package.json package-lock.json ./
RUN npm install
COPY . .
RUN npm run build --configuration=production
RUN ls -la /app/dist/lesgriots.web

# Étape 2 : Utiliser Nginx pour servir l'application
FROM nginx:alpine
COPY --from=build /app/dist/lesgriots.web /usr/share/nginx/html
COPY nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]