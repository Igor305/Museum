import { FileContentModel } from "../file.content.model";

export interface FileContentResponseModel{
    fileContentModels: FileContentModel[];
    status: boolean;
    message: string;
}