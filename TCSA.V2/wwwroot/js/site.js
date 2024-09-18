function initializeVideo() {
    videojs('my-video', {}, function () {
        console.log('Video.js player initialized');
    });
}

// Load and initialize GPT for ad
function loadGoogleAd() {
    window.googletag = window.googletag || { cmd: [] };

    // Load GPT library
    (function () {
        var gads = document.createElement('script');
        gads.async = true;
        gads.src = 'https://securepubads.g.doubleclick.net/tag/js/gpt.js';
        var node = document.getElementsByTagName('script')[0];
        node.parentNode.insertBefore(gads, node);
    })();

    // Define ad unit and display it
    googletag.cmd.push(function () {
        googletag.defineSlot('/23203265227/adunit1pabs', [1024, 768], 'div-gpt-ad-1726479800272-0')
            .addService(googletag.pubads());
        googletag.pubads().enableSingleRequest();
        googletag.enableServices();
    });
}
