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
      }
    },
  },
  plugins: [
    require('@tailwindcss/line-clamp')
  ],
}
