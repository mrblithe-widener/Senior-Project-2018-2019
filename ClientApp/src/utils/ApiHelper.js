//Constants which represent the possible error messages
export const NOT_FOUND = "Not Found"; //40* error
export const SERVER_ERROR = "A server error occured"; //5** error

/**
 * this function calls the given url and parses response as json
 * It will throw an error if it encounters one.
 * The error thrown will match the one defined in the constants above 
 * @param {the url of the function to make the api call to} url 
 */
export async function makeApiCall(url) {
    try {
        const response = await fetch(url);
        if (!response.ok) {
            if (response.status >= 400 && response.status < 500)
                throw new Error("Not Found");
            else
                throw new Error("A server error occured")
        } else
            return await response.json();
    } catch (e) {
        throw new Error(e);
    }
}
