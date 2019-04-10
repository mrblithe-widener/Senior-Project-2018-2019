import { makeApiCall } from "../utils/ApiHelper";

const requestSearch = "REQUEST_SEARCH";

const initalState = { results: undefined }

export const actionCreators = {
    requestSearch: name => async (dispatch, getState) => {
        const url = `/api/Index/SearchName${name}`;
        const results = makeApiCall(url);
        dispatch({ type: requestSearch, results: results });
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