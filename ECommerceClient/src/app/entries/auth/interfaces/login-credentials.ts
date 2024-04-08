interface AuthCredentials {
    name: string | null,
    presentation: string | null,
    email: string | null,
    password: string | null,
    confirmpass: string | null
}

export { AuthCredentials };