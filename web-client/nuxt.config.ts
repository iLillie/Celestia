import { defineNuxtConfig } from 'nuxt'

// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({
    app: {
      head: {
          meta: [
              { name: 'viewport', content: 'width=device-width, initial-scale=1' }
          ],
          link: [
              {rel: 'icon',  type: 'image/png', href: '/favicon-32x32.png'},
              {href: 'https://cdn.jsdelivr.net/npm/remixicon@2.5.0/fonts/remixicon.css', rel: 'stylesheet'},
              {href: 'https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600&display=swap', rel: 'stylesheet'}
          ]
      }
    },
    modules: ['@nuxtjs/tailwindcss', '@pinia/nuxt'],
})
