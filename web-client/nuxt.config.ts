import { defineNuxtConfig } from 'nuxt'

// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({
    app: {
      head: {
          titleTemplate: (title) => `ItJakt - ${title}`,
          meta: [
              { name: 'viewport', content: 'width=device-width, initial-scale=1' }
          ],
          link: [
              {rel: 'icon',  type: 'image/png', href: '/favicon-32x32.png'}
          ]
      }
    },
    modules: ['@nuxtjs/tailwindcss', '@pinia/nuxt'],
})
