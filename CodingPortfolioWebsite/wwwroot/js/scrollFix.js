window.forceScrollTopOnRefresh = () => {
    if ('scrollRestoration' in history) {
        history.scrollRestoration = 'manual';
    }

    // Remove hash
    if (window.location.hash) {
        history.replaceState(null, '', window.location.pathname);
    }

    // Force scroll to top BEFORE render
    window.scrollTo(0, 0);

    // Handle bfcache restores for navigation
    window.addEventListener('pageshow', function (event) {
        if (event.persisted) {
            window.scrollTo(0, 0);
        }
    });
};