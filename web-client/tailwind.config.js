const defaultTheme = require('tailwindcss/defaultTheme')

module.exports = {
  content: [],
  theme: {
    extend: {
      fontFamily: {
        'sans': ['Poppins', ...defaultTheme.fontFamily.sans],
      },
      maxWidth: {
        'ch-6': '24ch'
      },
      colors: {
        'portage': {
          50: '#eff1fe',
          100: '#e2e5fd',
          200: '#cbcffa',
          300: '#abb0f6',
          400: '#8b89f0',
          500: '#847bea',
          600: '#6650db',
          700: '#5842c0',
          800: '#27263d',
          900: '#3d337c',
          'bg': '#302E3F'
        },
      },
    },
  },
  plugins: [
    require('@tailwindcss/line-clamp')
  ],
}
