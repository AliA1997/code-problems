/**
 * @param {string[]} products
 * @param {string} searchWord
 * @return {string[][]}
 */
var suggestedProducts = function (products, searchWord) {
    // Start with m
    // Return first 3 in alphebitcal order -> n log n
    // Return first 3 words
    // Add first character mo
    // Return list of lists.
    // Add three characters mou.
    // If a word doesn't match the first n letters in the search term, it would NOT match the next n letters in a search term.
    // Words with same prefixes would be next to each other, when in sorted order.
    // Use a prefix tree dealing with prefixes problem, a better way is using two pointers.
    // Also know when word is removed, it is never considered again.
    // If the left pointer search term is valid(which is the pointer starting at the beginning of the array), and the right points search term is valid(which is pointer starting at the end of the array), then the all the words are valid. When sorted in alphebatical order.
    // Add first three into the result as sublist, starting from left pointer.
    // Time complexity is -> n log n + n * w + m

    let result = [];
    let lp = 0, rp = products.length - 1;
    // The number of keystrokes would be the length of the searchWord minus 1
    let numOfKeystrokes = searchWord.length, l = products.length;
    //Sort the array in alphebetical order.
    products.sort();


    for (let i = 0; i < numOfKeystrokes; i++) {
        let currentPrefix = searchWord.substring(0, i + 1);

        let matchTerms = [];
        //If left is less than right pointer, && if the current product is less than i + 1 or equal to the suffix.
        //If it's less than i + 1, it does not match the search query, then it's not a match. Move left pointer.
        while (lp < rp && (products[lp].length < i + 1 || products[lp].substring(0, i + 1) !== currentPrefix))
            lp += 1;

        while (lp < rp && (products[rp].length < i + 1 || products[rp].substring(0, i + 1) !== currentPrefix))
            rp -= 1;


        if(lp > rp) {
            result.push([]);
        } else {
            // Get all the matches.
            for (let j = lp; j <= rp && matchTerms.length < 3; j++) {
                if (products[j].substring(0, i + 1) === currentPrefix) {
                    matchTerms.push(products[j]);
                }
            }
            result.push(matchTerms);
        }

    }

    return result;
};