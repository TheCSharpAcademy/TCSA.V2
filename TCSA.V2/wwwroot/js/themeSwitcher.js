window.isDarkMode = function () {
    return window.matchMedia && window.matchMedia('(prefers-color-scheme: dark)').matches;
}

window.updateTheme = function () {
    if (window.isDarkMode()) {
        document.body.classList.add('dark-theme');
        return;
    }

    document.body.classList.remove('dark-theme');
}

window.updateTheme();

window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', window.updateTheme);
