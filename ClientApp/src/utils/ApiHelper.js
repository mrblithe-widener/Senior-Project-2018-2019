export const NOT_FOUND = "Not Found";
export const SERVER_ERROR = "A server error occured";

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