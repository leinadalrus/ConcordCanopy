// This file allows you to configure ESLint according to your project's needs, so that you
// can control the strictness of the linter, the plugins to use, and more.

const autoprefixer = require("./node_modules/autoprefixer/lib/autoprefixer");

// For more information about configuring ESLint, visit https://eslint.org/docs/user-guide/configuring/

module.exports = [
  {
    plugins: {
      tailwindcss: {},
      autoprefixer: {},
    }
  },
];
