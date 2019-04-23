//Constants for the types of actions that the loader will respond to
export const startLoading = "START_LOADING";
export const stopLoading = "STOP_LOADING";

//The inital state of the loading store

const initalState ={
    loading:[]
}

/**
 * The functions which create the actions to start and stop loading
 */

export const actionCreators ={
    startLoading:(dispatch)=>{
        dispatch({type:startLoading});
    },stopLoading:(dispatch)=>{
        dispatch({type:stopLoading});
    }
}

/**
 * This function updates the state of the store using the action provided
 * @param {the current state} state 
 * @param {the action to update the state with} action 
 */

export const reducer=(state,action)=>{
    switch(action.type){
        case startLoading:
            return {...state,loading:[...state.loading, true]}//Treating the state.loading like a queue
        case stopLoading:
            return {...state,loading:state.loading.splice(1)}//A trick to remove the first item in a functional style
        default:
            return state || initalState;
    }
}