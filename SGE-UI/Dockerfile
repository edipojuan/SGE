FROM node:10.16.3 as builder

WORKDIR /app

COPY package*.json /app/

# Add the two entries below
RUN mkdir -p node_modules/node-sass/vendor/linux-x64-51
RUN curl -L https://github.com/sass/node-sass/releases/download/v4.5.0/linux-x64-51_binding.node -o node_modules/node-sass/vendor/linux-x64-51/binding.node

RUN npm set strict-ssl false
RUN npm install
RUN npm rebuild node-sass

COPY . /app

RUN npm run build -- --output-path=./dist


FROM nginx:alpine

RUN rm -rf /usr/share/nginx/html/*

COPY nginx.conf /etc/nginx/nginx.conf

COPY --from=builder /app/dist /usr/share/nginx/html

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]