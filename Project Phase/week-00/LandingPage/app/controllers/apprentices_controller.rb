class ApprenticesController < ApplicationController

	before_action :authenticate_admin!

	def create
		@apprentice = Apprentice.new(apprentice_params)

		@apprentice.save
		redirect_to @apprentice
	end

	def show
		@apprentice = Apprentice.find(params[:id])
				redirect_to :admin
	end

	def destroy
		@apprentice = Apprentice.find(params[:id])
		@apprentice.destroy
		redirect_to :admin
	end

	private

	def apprentice_params
		params.require(:apprentice).permit(:name)
	end

end
