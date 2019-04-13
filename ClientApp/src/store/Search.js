import { makeApiCall, NOT_FOUND } from "../utils/ApiHelper";
import {createError} from "./Error";

const requestSearch = "REQUEST_SEARCH";

const initalState = { results: undefined }

export const actionCreators = {
    requestSearch: name => async (dispatch, getState) => {
        if (!name || name == "" || name.match(/^\s*$/)) {
            dispatch({ type: requestSearch, results: undefined })
        } else {
            const url =name.match(/\d{5}/)? `/api/Index/SearchZip/${name.trim()}`:`/api/Index/SearchName/${name}`
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

export const reducer = (state, action) => {
    switch (action.type) {
        case requestSearch:
            return { ...state, results: action.results };
        default:
            return state || initalState;
    }
}
