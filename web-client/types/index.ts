export interface Company {
    id?: number,
    name: string,
    homepageUrl?: string,
    logoUrl?: string,
    address?: string,
    contacts?: Contact[]
}

export interface Contact {
    id?: number,
    name?: string,
    phone?: string,
    email?: string,
    address?: string
}

export interface Job {
    id?: number,
    title: string,
    description?: string,
    postingUrl?: string,
    address?: string,
    status: string
}

export interface Folder {
    id?: number,
    name: string,
    description: string,
    color: string,
    jobs?: Job[]
}
