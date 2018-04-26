class ProjectsController < ApplicationController

	before_action :authenticate_admin!
	
	def create
		@project = Project.new(project_params)

		@project.save
		redirect_to @project
	end

	def show
		@project = Project.find(params[:id])
		redirect_to :admin
	end

	def destroy
		@project = Project.find(params[:id])
		@project.destroy
		redirect_to :admin
	end

	private

	def project_params
		params.require(:project).permit(:thumbnail_url, :title, :description)
	end

end