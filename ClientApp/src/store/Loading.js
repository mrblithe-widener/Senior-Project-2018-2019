export const startLoading = "START_LOADING";
export const stopLoading = "STOP_LOADING";

const initalState ={
    loading:[]
}

export const actionCreators ={
    startLoading:(dispatch)=>{
        dispatch({type:startLoading});
    },stopLoading:(dispatch)=>{
        dispatch({type:stopLoading});
    }
}


export const reducer=(state,action)=>{
    switch(action.type){
        case startLoading:
            return {...state,loading:[...state.loading, true]}
        case stopLoading:
            return {...state,loading:state.loading.splice(1)}
        default:
            return state || initalState;
    }
}