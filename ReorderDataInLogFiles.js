/**
 * @param {string[]} logs
 * @return {string[]}
 */
var reorderLogFiles = function(logs) {
    let dLogs = [];
    let lLogs = [];

    // Go through logs, put digits in dLogs, and letter logs in lLogs.
    // First condition letter logs are in front of digit logs.
    for(const lIdx in logs) {
        const log = logs[lIdx];
        if(isNaN(parseInt(log.at(log.length -1)))) 
            lLogs.push(log);
        else
            dLogs.push(log);
    }

    lLogs.sort((a, b) => {
        const contentOfA = a.split(' ').slice(1).join(' ');
        const contentOfB = b.split(' ').slice(1).join(' ');
        return contentOfA.localeCompare(contentOfB);
    });
    
    return lLogs.concat(dLogs);
};