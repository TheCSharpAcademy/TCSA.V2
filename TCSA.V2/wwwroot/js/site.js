function loadGoogleAd(projectId) {
    window.googletag = window.googletag || { cmd: [] };

    (function () {
        var gads = document.createElement('script');
        gads.async = true;
        gads.src = 'https://securepubads.g.doubleclick.net/tag/js/gpt.js';
        var node = document.getElementsByTagName('script')[0];
        node.parentNode.insertBefore(gads, node);
    })();

    googletag.cmd.push(function () {
        const adId = `div-gpt-ad-${projectId}`;
        googletag.defineSlot('/23203265227/proj-reqs-728-90', [970, 90], adId)
            .addService(googletag.pubads());
        googletag.pubads().enableSingleRequest();
        googletag.enableServices();
        googletag.display(adId);
    });
}
