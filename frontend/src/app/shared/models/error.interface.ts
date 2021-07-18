export interface ErrorItem {
    property: string,
    message: string,
}

export interface ErrorResponse {
    code: number,
    errors: ErrorItem[],
    hasErrors: boolean,
}