/** @type {import('tailwindcss').Config} */
module.exports = {
  prefix: "tw-",
  content: ["**/*.{html,cshtml,razor,razor.cs}"],
  theme: {
    screens: {
      "xs": "144px",
      "sm": "768px",
      "md": "992px",
      "lg": "1400px"
    },
    extend: {
    },
  },
  plugins: [],
}

