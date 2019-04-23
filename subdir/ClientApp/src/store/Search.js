import { makeApiCall, NOT_FOUND } from "../utils/ApiHelper";
import {createError} from "./Error";

//The action type that will be used to request the search information
const requestSearch = "REQUEST_SEARCH";

//The intial state of the reducer
const initalState = { results: undefined }

/**
 * This action will request and handle any errors having to do with searching for a school
 */
export const actionCreators = {
    requestSearch: name => async (dispatch, getState) => {
        if (!name || name == "" || name.match(/^\s*$/)) {//Do not make an api call if whitespace or falsy
            dispatch({ type: requestSearch, results: undefined })
        } else {
            const url =name.match(/\d{5}/)? `/api/Index/SearchZip/${name.trim()}`:`/api/Index/SearchName/${name}`//Check if there is only a zip code as a field
            try {
                const results = await makeApiCall(url);
                dispatch({ type: requestSearch, results: results });
            } catch (e) {
                if (e.message == NOT_FOUND)
                    dispatch({ type: requestSearch, results: undefined })
                else
                    dispatch({type: createError, errorMessage:e.message});
            }
        }
    }
}

/**
 * The reducer which processes the resulting action request
 */

export const reducer = (state, action) => {
    switch (action.type) {
        case requestSearch:
            return { ...state, results: action.results };
        default:
            return state || initalState;
    }
}
